const keyboard = [
    [
        "a",
        "b",
        "c",
        "d",
        "e",
        "1",
        "2",
        "3"
    ],
    [
        "f",
        "g",
        "h",
        "i",
        "j",
        "4",
        "5",
        "6"
    ],
    [
        "k",
        "l",
        "m",
        "n",
        "o",
        "7",
        "8",
        "9"
    ],
    [
        "p",
        "q",
        "r",
        "s",
        "t",
        ".",
        "@",
        "0"
    ],
    [
        "u",
        "v",
        "w",
        "x",
        "y",
        "z",
        "_",
        "/"
    ]
]
const buildHash = () => {
    const hash = {};
    for (let i = 0; i < keyboard.length; i++) {
        const row = keyboard[i];
        for (let j = 0; j < row.length; j++) {
            const letter = row[j];
            hash[letter] = {
                y: i,
                x: j
            };
        }
    }
    return hash;
}

const getWordDifference = (hash, word) => {
    let lastPos = {
        x: 0,
        y: 0
    }
    let rv = 0;
    const text = word
        .split('')
        .forEach(letter => {
            rv += Math.abs(hash[letter].x - lastPos.x);
            rv += Math.abs(hash[letter].y - lastPos.y);
            rv++; // "Ok"
            lastPos = hash[letter]
            console.log({letter, pos: hash[letter], rv})
        })
    console.log({lastPos, rv})
    // const rv = word.split
    return rv;
}

const tvRemote = (word) => {
    const hash = buildHash();
    return getWordDifference(hash, word)
}
