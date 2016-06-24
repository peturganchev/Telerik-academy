function digits(arguments) {
    var digit = arguments[0];
    switch (digit) {
        case "0":
            console.log("zero");
            break;
        case "1":
            console.log("one");
            break;
        case "2":
            console.log("two");
            break;
        case "3":
            console.log("three");
            break;
        case "4":
            console.log("four");
            break;
        case "5":
            console.log("five");
            break;
        case "6":
            console.log("six");
            break;
        case "7":
            console.log("seven");
            break;
        case "8":
            console.log("eight");
            break;
        case "9":
            console.log("nine");
            break;
        default:
            console.log("not a digit");
            break;
    }
}

digits(["0"]);
digits(["1"]);
digits(["2"]);
digits(["3"]);
digits(["4"]);
digits(["5"]);
digits(["6"]);
digits(["7"]);
digits(["8"]);
digits(["9"]);
digits(["-1"]);
