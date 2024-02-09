# ProiectIMR

State of the art: https://docs.google.com/document/d/173qZQpU6bNXTV3dU1szgOx5TJXTGEgUZU6vC9sd0DDk/edit#heading=h.bcldxwdefncd

Identification of main modules of the application: https://docs.google.com/document/d/1kxBPMhPApqfee1oU5uDffRYoxIoEt1VzvX3hOEkILBQ/edit#heading=h.bcldxwdefncd

Demo: https://www.youtube.com/watch?v=fWlbVB6I22c

Poveste originala:

***
Ugh! How disgusting these slugs are!... I hate the fact that every day I have to get rid of them. But what alternative do I have? Ever since I haunt this fountain, not only have I started to remember many memories from my past life, but I can also interact somewhat with the material world.

I wonder how long I've been in this forest? 100 years? Maybe even more... What should I do if luck wasn't on my side... In fiction novels, all those who are reincarnated benefit from all sorts of skills to help fulfill their every desire, but for me, there wasn't enough energy even to offer me a regular human body.

Finally, I'm done. I can't stand seeing such creatures crawling on my house. Huh, what's that sound? It seems Spike has already rooted out his future dinner. Well, since I have nothing better to do, I guess I'll go see what foolish animal dared to venture into these death-scented woods.

Huh, a shoe? From what I can tell, they're a girl's shoes... Don't tell me... Spike! Stop! Stop!

Damn it! He doesn't want to understand me at all... Well, Spike, you've been a good neighbor, but it seems our paths will diverge today...

But how can I get rid of him? With a stick like the slugs? No, I don't think that will work... Hmm, I guess the only option is to use my spiritual power...

Goodbye, Spike. I hope you won't hold a grudge against me from the afterlife... Alright, now. Let's go see whom I've saved.

It seems I was right. From what I can see, she's just an innocent girl. Oh Spike, you truly became heartless in old age...

Hmm, why isn't she moving? Has she been injured or fainted from fear?

"Cold, so cold."

Uhh, that's not good. I forgot that it's much colder in this place than elsewhere, and she's dressed very thinly. This isn't good; at this rate, she'll get hypothermia. I need to do something...

From what I can tell, she probably set up that spot to make a fire, and while searching for dry wood, she was found by Spike...

I think I've gathered enough wood. Let's see if I can start the fire...

So far, I've only used spiritual power to cast spells related to water, so using a spell to make fire has almost drained all my spiritual power.

I don't think I have much time left before I go back to sleep again. I think I'll use the rest of my spiritual power to leave her some water, and then I'll return to the fountain. From what I remember, there was a bucket thrown outside.

I think that's it. I've done everything in my power to help her. Now it all depends on her. Hmm, I'm very sleepy now. I didn't think a ghost could be so drowsy...

......................................


Huh, what's happening? Where am I? Didn't I return to the fountain? No, from what I can tell, I'm not even in the forest anymore. What happened?

Eh, don't tell me I've been promoted from a ghost haunting a fountain to one haunting a living person?

It seems this girl is just having bad luck. She barely managed to escape from the Cursed Forest, and now she's run into a criminal. Hmm, or maybe he's the reason she entered the Cursed Forest in the first place... Anyway, besides Spike, he'll be much easier to get rid of...

Well, maybe I've become some sort of pet now, but at least I'll have the chance to see what lies beyond the borders of the Cursed Forest without putting my soul in danger. Plus, it's much more pleasant to be in the company of a beautiful girl than disgusting slugs.

***


Tema 11

Rezumat:
- modelare si animare mana de fantoma si limax, modelare capac nou fantana, pardoseala cabana , liane etc.
- modificare locomotie player(pana la urma am decis sa las cum a fost, deoarece asa aratau toate tutorialele-playerul va fi Origin si se va deplasa doar la deplasarea joystikului mainii stangi)
- lucrat la interactiunea dintre player si diverse obiecte si personaje (am pus un link in care playerul vaneaza limaxi de pe fantana cu un bat): https://drive.google.com/file/d/1chqOUpgMWcKGdOVqHlQGenDhTjF7pAB3/view?usp=drivesdk
 


Tema 10

Rezumat:
- modelare si animare obiect interactiv complex pentru a testa sincronizarea dintre player si obiectele interactibile (o galeata cu maner)
- dupa nenumarate teste, am ajuns la concluzia ca folosirea de animatii individuale ale mainii pentru fiecare obiect cu care va interactiona playerul si animarea obiectelor si adaugarea la schelet a unor attach point-uri este cea mai buna solutie (am pus in video videos_011)
- mici modificari la locomotia playerului (inca nu m-am hotarat daca voi face deplasarea playerului asemenea zborului unei fantome, deoarece vor exista dificultati in apucarea obiectelor. Probabil voi adauga un efect de zbor doar cand playerul va sta pe loc)
- adaugare de elemente UI : meniu sub forma de semn de lemn
- creare scena lobby, de unde se pot accesa episoadele povestii


Tema 9

Rezumat:
- lucru la deplasarea playerului (deocamdata arata bine, vor mai urma inbunatatiri pentru a facilita interactiunea cu obiectele)
- am inceput sa lucrez la interactiunea dintre player si obiecte (am pus in video videos_010)
- creare de obiecte interactive (deocamdata doar crengi)
- inceperea scenei 3 (testarea de asseturi de suprafata de apa - acestea le-am importat)
 



Tema 8

Rezumat:
- modelare asseturi pentru scena 1 (pietre si bruieni)
- creare fisiere audio pe baza textului (https://play.ht/). Am ales acest tool deoarece nu cerea bani (cel putin primele mii de cuvinte) si functioneaza si suficient de bine.
- creare scripturi ce permite comunicarea dintre player si caractere (am pus in movie_009.mp4 cam cum ar arata interactiunea)
- lucru la deplasarea playerului (Din cate am vazut in VR se deplasa doar camera, iar playerul statea pe loc. Am incercat mai multe tehnici prin care sa-l fac pe player sa se deplaseze, insa mai e de lucru, deoarece trebuie ca playerul sa aiba senzatia ca leviteaza. In plus, prin unele obiecte va putea trece, iar prin altele nu).
 
 
 
Tema 7

Rezumat:
- creare scena (Padurea Bantuita) corespunzatoare capitolului 1 al povestii interactive
- creare asseturi necesare:copaci deformati, tufisuri, texturi iarba, fantana, tarantula (toate asseturile (mesh si texturi),inafara de skybox au fost create de mine)
- de remarcat ar fi fantana, care mi se pare ca a iesit grozav (are adaugat si o NM creata speciala pentru ea prin procesul de bake de la un mesh cu mult mai multe poligoane)
- de notat ar fi ca scena nu e completa, deoarece mai trebuie adaugata o cabana si distribuita mai bine vegetatia, insa aceasta ilustreaza destul de bine atmosfera unei paduri bantuite
- video-ul demonstrativ este movie_006.mp4, adaugat in repository (in acest film mainile sunt scoase pentru a se vedea mai bine scena)
