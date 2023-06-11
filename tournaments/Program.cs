Player michael = new Player("Michael the Goat", "Jordan", 23);
Player axa = new Player("Axa", "Uribe", 10);
Player leo = new Player("Leo", "Nardo", 69);
Player mom = new Player("your", "mom", 88);

michael.updateJersey(45);
michael.updateJersey(23);


Team beasts = new Team("beasts");
beasts.AddPlayer(mom);
beasts.AddPlayer(leo);


Team fireballs = new Team("Fireballs");
fireballs.AddPlayer(axa);
fireballs.AddPlayer(michael);


Match superbowl = new Match(fireballs, beasts);
superbowl.DecideWin();

fireballs.Display();
beasts.Display();




