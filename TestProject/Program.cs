// Initialize health points for hero and monster
int heroHealth = 10;
int monsterHealth = 10;

Random random = new Random();

//Game Loop
while (heroHealth > 0 && monsterHealth > 0) {
    
    //Hero attack #1
    int heroAttack = random.Next(1,11);
    monsterHealth -= heroAttack;
    Console.WriteLine($"Hero attacks monster and deals {heroAttack} damage. Monster's remaining health: {monsterHealth}.");

    //Check if the monster is defeated
    if (monsterHealth < 0) {
        Console.WriteLine("Monster is defeated! Hero wins!");
        break;
    }
    //Check if monster is defeated
    if (monsterHealth <= 0) {
        Console.WriteLine("Monster is defeated! Hero wins!");
    }


    //Monster attack back
    int monsterAttack = random.Next(1,11); // Random value between 1 and 10;
    heroHealth -= monsterAttack;
    Console.WriteLine($"Monster attacks hero and deals {monsterAttack} damage. Hero's remaining health: {heroHealth}");



    // Check if the hero is defeated
    if (heroHealth <= 0) {
        Console.WriteLine("Hero is defeated! Monster Wins!");
        break;
    }
}