# Proiect-IPDP
Cod sursa pentru proiect IPDP.
Am creat o aplicatie in C# in care iti poti crea un cont si modifica datele.
Pentru baza de date am folosit Microsoft Access 2010.
La pornirea aplicatiei, programul verifica daca ultima oara aplicatia a fost inchisa fortat, verificand in baza de date statusul daca a ramas Online sau Offline, in cazul in care a ramas statusul cuiva Online, i se va deschide automat pagina personala.
Am implementat un sistem care verifica atunci cand iti creezi un cont nou daca user-ul e deja existent si afiseaza mesajul de eroare, pe langa asta, il va impiedica pe utilizator sa se logheze pe un cont care a ajuns cumva sa existe de mai multe ori in baza de date.
Dupa descarcarea programului, executabilul se va afla in folderul bin/debug, alaturi de fisierul cu baza de date, unde pot fi gasite conturile curente.
