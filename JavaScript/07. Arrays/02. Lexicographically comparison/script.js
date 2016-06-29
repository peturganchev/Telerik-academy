function lexicographicallyComparison(arguments) {
    var word = arguments[0].split("\n");
    if (word[0] < word[1]) {
        console.log("<");
    } else if (word[0] > word[1]) {
        console.log(">");
    } else {
        console.log("=");
    }
}
lexicographicallyComparison(['hello\nhalo']);
console.log("----------------------");
lexicographicallyComparison(['food\nfood']);
