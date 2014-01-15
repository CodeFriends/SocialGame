:- use_module(library(odbc)).
:- dynamic liga/3.

carrega_ligacoes:-
	retractall(liga(_,_,_)),
	abre_conexao_bd(CONN),
	findall((Id_utilizador1,Id_utilizador2,Forca_ligacao),
		   odbc_query(CONN,
		   'select id_utilizador1, id_utilizador2, forca_ligacao from Ligacao',
		   row(Id_utilizador1, Id_utilizador2,Forca_ligacao)), Ligacoes),
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
guarda_ligacoes([(ID1,ID2,F)|T]):-assertz(liga(ID1,ID2,F)),guarda_ligacoes(T).


calcula_tamanho(Origem,Tamanho):-
	carrega_ligacoes,
	amigos_proximos(Origem,L),
	amigos_dos_amigos(L,LR),
	union(L,LR,L2),	length(L2,Tamanho).

amigos_proximos(Origem,L):-
findall(X,(liga(Origem,X,_);liga(X,Origem,_)),L).


amigos_dos_amigos([],[]).

amigos_dos_amigos([H|T],LR):-
	amigos_proximos(H,L),
	amigos_dos_amigos(T,L2),union(L,L2,LR).


caminho_mais_curto(Orig,Dest,Perc) :- bfs([[Orig]],Dest,P), reverse(P,Perc).

bfs([Prim|_],Dest,Prim) :- Prim=[Dest|_].
bfs([[Dest|_]|Resto],Dest,Perc) :- !, bfs(Resto,Dest,Perc).
bfs([[Ult|T]|Outros],Dest,Perc):-
		findall([Z,Ult|T],proximo_no(Ult,T,Z),Lista),
		append(Outros,Lista,NPerc),
		bfs(NPerc,Dest,Perc).

proximo_no(X,T,Z) :- liga(X,Z,_), \+ member(Z,T).



nodos(Id,X,Y,Z):- carrega_grafo(Id,L),!,member((X,Y,Z),L).

carrega_grafo(Origem,LR):-
	carrega_ligacoes,
	grafo_amigos_proximos(Origem,L),grafo_amigos_dos_amigos(L,L2),union(L,L2,L3),grafo_remove_repetidos(L3,LR).


grafo_amigos_proximos(Origem,L):-
findall((Origem,X,Forca),(liga(Origem,X,Forca);liga(X,Origem,Forca)),L).




grafo_amigos_dos_amigos([],[]).

grafo_amigos_dos_amigos([(_,H,_)|T],LR):-
	grafo_amigos_proximos(H,L),
	grafo_amigos_dos_amigos(T,L2),append(L,L2,LR).


grafo_remove_repetidos(L,LR):-grafo_remove_repetidos(L,[],LR).

grafo_remove_repetidos([],L,L).

grafo_remove_repetidos([(X,Y,Z)|T],L,LR):-
	\+member((Y,X,_),T),
	\+member((X,Y,_),T),
	grafo_remove_repetidos(T,[(X,Y,Z)|L],LR).

grafo_remove_repetidos([_|T],L,LR):-
	grafo_remove_repetidos(T,L,LR).







