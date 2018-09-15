function lemmingBattle(battlefield: number, green: Array<number>, blue: Array<number>) {
  green.sort();
  blue.sort();
  let round: number = 0;
  while (green.length > 0 && blue.length > 0) {
    const blueBattleField = []
    for (let i = 0; i < battlefield; i++) {
      blueBattleField.push(blue.pop())
    }
    const greenBattleField = []
    for (let i = 0; i < battlefield; i++) {
      greenBattleField.push(green.pop())
    }
    round++;
    console.log({round, greenBattleField, blueBattleField})
    for (let i = 0; i < battlefield; i++) {
      const g = greenBattleField[i];
      const b = blueBattleField[i];
      if (g > b){
        console.log("green wins");
        const r = g -b;
        green.push(r);
      } else if (g < b) {
        console.log("blue wins");
        const r = b -g;
        blue.push(r);
      } 
    }
    blue.sort().reverse();
    green.sort().reverse();
  }

  // console.log("game over", { green, blue })
  if (green.length > blue.length) {
    return `Green wins: ${green.join(" ")}`
  } else if (green.length < blue.length) {
    return `Blue wins: ${blue.join(" ")}` 
  } else {
    return "Green and Blue died"
  }
}


const Test = {
  assertEquals: (actual :string, expected :string) => {
      if (actual == expected){
        console.log(`***** passed : ${actual} == ${expected}`)
      } else {
        console.log(`^^^^ failed !`)
        console.log(`got: ${actual}`)
        console.log(`expected: ${expected}`)

      }
  }
}
Test.assertEquals(lemmingBattle(5, [10], [10]), "Green and Blue died");
Test.assertEquals(lemmingBattle(2, [20, 10], [10, 10, 15]), "Blue wins: 5");
Test.assertEquals(lemmingBattle(3, [50, 40, 30, 40, 50], [50, 30, 30, 20, 60]), "Green wins: 10 10");
Test.assertEquals(lemmingBattle(1, [20, 30], [15]), "Green wins: 20 15");