function maxUpSeq(arguments) {
    var numbers = arguments[0].split("\n").slice(1),
        counter = 1,
        best = 0,
        current = numbers[0];
    for (var i = 0; i < numbers.length; i++) {
        if (current < +numbers[i + 1]) {
            counter++;
        } else {
            if (counter > best) {
                best = counter;
            }
            counter = 1;
        }
        current = numbers[i + 1];
    }
    console.log(best);
}

maxUpSeq(['8\n7\n3\n2\n3\n4\n2\n2\n4']);
