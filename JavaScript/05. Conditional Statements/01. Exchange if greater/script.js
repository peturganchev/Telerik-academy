function exchangeIfGrater(arguments) {
    var a = arguments[0],
        b = arguments[1];

    if (a < b) {
        console.log(a + " " + b);
    } else {
        console.log(b + " " + a);
    }
}

exchangeIfGrater(["5", "2"]);
exchangeIfGrater(["3", "4"]);
exchangeIfGrater(["5.5", "4.5"]);
