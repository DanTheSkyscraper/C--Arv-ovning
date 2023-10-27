
//Komposition: "har-en"

// Ny klass eller inte?
//  Lite data skiljer = ingen ny klass
//  Mycket data skiljer = ny klass
//  Funktion skiljer = ny klass
// Komposition eller arv?
//  "är en": arv
//  "har en": komposition

// Fighter f1 = new Fighter();
// f1.strength = 12;

Axe a = new Axe();
Sword s = new Sword();

Weapon w = new Axe();

a.Attack();

// Console.WriteLine(w.Name);

// if (w is Axe)
// {
//     ((Axe)w).Grind();
// }

List<Weapon> weapons = new List<Weapon>(); //Polymorfism (A nivå)
weapons.Add(new Axe());

Console.ReadLine();


