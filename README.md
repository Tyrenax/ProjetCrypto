# ProjetCrypto
Projet de cryptographie basique, un cryptage inventé ici grâce au produit des matrices, et un cryptage classique AES a l'aide de .NET
Utilise windows form en c# pour avoir une petite interface graphique ou crypter et décrypter
Attention ! Fond d'écran moche !
En détail :


---Cryptage Perso---

Pour le cryptage personnel, on récupère la chaîne de caractère a crypter et on la transforme en un vecteur colonne.
Grace a la fonction GetColumnVector qui transforme simplement chaque char en int en utilisant la logique A=0,B=1 ...
Ensuite, on génère une matrice qui sera notre clé grâce a la fonction GenerateMatrix qui randomise une matrice de taille n(n étant la taille de la taille de caractère)
Ici, on voit déjà les problèmes d'un tel encryptage, je ne récupère pas la clé donc elle sera perdue à tout jamais et plus le message est long plus le nombre
d'opération va croître de façon exponentielle (ou quadratique mais bref)
Pour crypter le message, l'on va donc effectuer le produit matriciel entre la clé (key) et le vecteur colonne. (col)
On va mettre le résultat dans une array "encrypted" que l'on va ensuite remettre en string grâce a un modulo et en ajoutant 'A' pour commencer au bon endroit.

---Decryptage Perso---

Ici, la seule subtilité est que pour décrypter, on aura besoin de la matrice inverse de la clé, car dans le produit matriciel, si K est la clé, M est la chaîne de caractère
à crypter et E la chaine encrypter alors pour crypter on à K*M = E si l'on veut décrypter alors K^-1*K*M = K^-1*E les K se simplifie et donc M = K^-1*E  
Vu que je n'avais pas envie de faire un algorithme pour inverser la matrice, j'ai utilisé une bibliothèque non-standard "MathNet.Numerics" vu que les éléments de key
sont des int et que j'ai besoin de double pour inversé je transforme key en keyArray qui elle est double , je fais l'inversion en d'abord transformant l'Array
en matrice puis en appliquant inverse a celle-ci et ensuite et après le produit matriciel je reconverti le tout en int pour obtenir la chaine de caractère initiale
NB : j'ai modifié le GenerateMatrix en le faisant seulement générer des matrices diagonales non nulle car sinon on aurait des matrices non-inversible de temps en temps et donc c'est pas ouf

---CryptageNET---

Je crée une array random ensuite je la combine au password pour créer une première clé en utilisant PBKDF2 et en faisant aller l'algorithme 10 000 pour avoir un truc bien solide.
J'obtiens donc une clé de 32 octets, j'utilise ensuite AES cipher ou j'introduis ma clé et génère un vecteur aléatoire IV.
Ensuite on crée l'encrypteur toujours a l'aide de AES et on crée un flux mémoire où l'on va stockée d'abord le salt et le IV qui sera utilisé pour décrypter.
On crée un flux de cryptage et de stream, dans le flux de cryptage, l'on se sert du flux de mémoire et de l'encrypteur pour encrypter le message.
Le StreamWriter sert seulement à pouvoir écrire le message à encrypter dans le CS et donc on retourne le flux de mémoire (ms) pour pouvoir décrypter si besoin.

--DecryptageNET--
Le décryptage est très simple grâce au ms l'on va pouvoir retrouver le salt et le vecteur IV ce qui va permettre de refaire l'algorithme combiner avec
le mot de passe et donc retrouver notre clé ensuite, on utilise AES pour decrypter le message grâce a la clé et le tour est joué !

