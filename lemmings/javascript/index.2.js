
var Test = {
    assertEquals: function (actual, expected) {
        if (actual == expected) {
            console.log("***** passed : " + actual + " == " + expected);
        }
        else {
            console.log("^^^^ failed !");
            console.log("got: " + actual);
            console.log("expected: " + expected);
        }
    }
};
Test.assertEquals(lemmingBattle(5, [10], [10]), "Green and Blue died");
Test.assertEquals(lemmingBattle(2, [20, 10], [10, 10, 15]), "Blue wins: 5");
Test.assertEquals(lemmingBattle(3, [50, 40, 30, 40, 50], [50, 30, 30, 20, 60]), "Green wins: 10 10");
Test.assertEquals(lemmingBattle(1, [20, 30], [15]), "Green wins: 20 15");
