
from pyswip import Prolog
prolog = Prolog()

prolog.assertz("padres(cecilia,antonio,julia)");
prolog.assertz("padres(samanta,rosendo,esteban)");

prolog.assertz("padres(julia,esteban,andres)");
prolog.assertz("padres(julia,esteban,daniel)");


prolog.assertz("padres(roberto,carolina,gonzalo)");
prolog.assertz("padres(irene,martin,nelson)");

prolog.assertz("hermano(irene,esteban)");
prolog.assertz("hermano(carolina,julia)");

prolog.assertz("hermanos(A,B):- padres(M,P,A),padres(M,P,B),A\=B");
prolog.assertz("abuelo(X,Y):- padres(Z,W,Y),(padres(U,X,Z);padres(U,X,W))");
prolog.assertz("tio(X,Y):- padres(M,P,Y),(hermano(X,P);hermano(X,M))");
prolog.assertz("primo(X,Y):- (tio(Z,X),padres(Z,U,Y));(tio(Z,X),padres(U,Z,Y))");
prolog.assertz("nieto(X,Y):- abuelo(Y,X)");

for elemento in prolog.query("abuelo(X,Y)"):
        print(elemento["X"]," es el abuelo de ",elemento["Y"]) 
for elemento in prolog.query("primo(X,Y)"):
        print(elemento["X"]," es el primo de ",elemento["Y"])
for elemento in prolog.query("nieto(X,Y)"):
        print(elemento["X"]," es el nieto de ",elemento["Y"])
        
