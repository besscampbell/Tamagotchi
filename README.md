# Tamagotchi Pet

#### Play the game from your childhood!, 12.16.2020 

#### By _**Bess Campbell and Joey Giunta**_

## Description

 In the 90's Tamagotchis were popular. They were electronic pets that you could carry around and press buttons to feed it, play with it, and put it to sleep. If you didn't give it enough food, attention, or rest, it would die.

  Make a web app where you can create a Tamagotchi object by giving it a name and submitting a form.

 It should have properties for the amount of food, attention, and rest it currently has.

  There should be a main page displaying the names of all your Tamagotchi objects with the values of their properties.

 Create buttons to call methods to:

 Feed it, play with it, and put it to sleep. These methods should modify the properties of a single Tamagotchi object - such as a food property.
 Make time pass. Every time you press it, the food, happiness and sleep properties of all Tamagotchis should decrease. If any of these properties get to 0, the Tamagotchi object should report that it's dead.


 Specs 
 pet object => name, food, attention, rest

 list<pet>

 ids

 methods:
 feed ++food
 play ++attention
 sleep ++rest

 time button: --food --attention --rest

 pet dead: food/attention/rest==0