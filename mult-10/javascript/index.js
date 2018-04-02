    const closestMultiple10 = num => {
        const mod = num % 10;
        let rv = num;
        if (mod >= 5){
        rv += (10 - mod)  
        } else {
        rv -= mod 
        }
        return rv;
    };





    

  const duckduck = (players, goose) => {
    let _goose = goose;
    while (_goose > players.length){
        _goose -= players.length;
    }
    return players[_goose-1].name;
  }

  class Player {
    constructor(name) {
        this.name = name;
    }
  }
  
  let ex_names = ["a", "b", "c", "d", "c", "e", "f", "g", "h", "z"];
  let players = ex_names.map((n) => new Player(n));

  console.log(duckduck(players, 12))
