function lemmingBattle_old(battlefield: number, green: Array<number>, blue: Array<number>) {
  green.sort();
  blue.sort();
  let round: number = 0;
  while (round <= battlefield && green.length > 0 && blue.length > 0) {
    // console.log({ battlefield, green, blue })
    const blueFighter: number = blue.pop();
    const greenFighter: number = green.pop();
    round++;
    // console.log("current Fight", { round, greenFighter, blueFighter });
    if (blueFighter > greenFighter) {
      // console.log("blue won")
      const remaining: number = blueFighter - greenFighter;
      blue.push(remaining);
      blue.sort().reverse();
    } else if (blueFighter < greenFighter) {
      // console.log("green won")
      const remaining: number = greenFighter - blueFighter;
      green.push(remaining);
      green.sort().reverse();
    } else {
      // console.log("tie")
    }
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


const Test_old = {
  assertEquals: (actual :string, expected :string) => {
      if (actual == expected){
        console.log(`passed : ${actual} == ${expected}`)
      } else {
        console.log(`failed !`)
        console.log(`got: ${actual}`)
        console.log(`expected: ${expected}`)

      }
  }
}
// Test.assertEquals(lemmingBattle(5, [10], [10]), "Green and Blue died");
// Test.assertEquals(lemmingBattle(2, [20, 10], [10, 10, 15]), "Blue wins: 5");
Test.assertEquals(lemmingBattle(3, [50, 40, 30, 40, 50], [50, 30, 30, 20, 60]), "Green wins: 10 10");
// Test.assertEquals(lemmingBattle(1, [20, 30], [15]), "Green wins: 20 15");