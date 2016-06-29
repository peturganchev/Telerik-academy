function maxSeq(arguments) {
    var array = arguments[0].split("\n");
    currentsequence = 1,
        maxSequence = 0,
        currentNumber = array[0];
    for (var i = 1; i < array.length; i++) {
        if (currentNumber === array[i]) {
            currentsequence++;
        } else {

            currentsequence = 1;
            currentNumber = array[i];
        }
        if (currentsequence > maxSequence) {
            maxSequence = currentsequence;
        }
    }
    console.log(maxSequence);
}

maxSeq(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']);
