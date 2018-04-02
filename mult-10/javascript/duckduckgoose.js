const duckduck = (players, goose) =>{
    // find mod
    let mod = goose % players.length;
    let adjusted = mod - 1;
    if (adjusted < 0){
        adjusted = players.length - 1
    }
    console.log({mod, adjusted})
    return players[adjusted];
}


console.log(duckduck(["a", "b", "c"], 3)) // => "c"
console.log(duckduck(["a", "b", "c"], 1)) // => "a"
console.log(duckduck(["a", "b", "c"], 10)) // => "a"
console.log(duckduck(["a", "b", "c"], 5)) // => "b"