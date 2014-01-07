:- use_module(library(odbc)).


carrega_ligacoes:-
	abre_conexao_bd(CONN),
	findall((Id_utilizador1,Id_utilizador2),
		   odbc_query(CONN,
		   'select id_utilizador1, id_utilizador2 from Ligacao',
		   row(Id_utilizador1, Id_utilizador2)), Ligacoes),
	odbc_disconnect(CONN),
	guarda_ligacoes(Ligacoes).

abre_conexao_bd(CONN):-
	odbc_connect('Gandalf',CONN,
	[ user('ARQSI104'),
	password('Code5!'),
	  alias('Gandalf'),
	  open(once)
	]).

guarda_ligacoes([]).
guarda_ligacoes([(ID1,ID2)|T]):-assertz(guarda_ligacoes(ID1,ID2)),cria(T).

