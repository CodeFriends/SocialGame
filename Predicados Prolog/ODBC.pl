:- use_module(library(odbc)).

abre_bd:-
        odbc_connect('gandalf.dei.isep.ipp.pt\sqlexpress', _,
                     [ user('ARQSI104'),
                       password('Code5!'),
                       alias('gandalf.dei.isep.ipp.pt\sqlexpress'),
                       open(once)
                     ]).
