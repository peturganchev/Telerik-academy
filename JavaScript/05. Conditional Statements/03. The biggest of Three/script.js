function biggestOfThree(arguments) {
    var a = Number(+arguments[0]),
        b = Number(+arguments[1]),
        c = Number(+arguments[2]);
    if (b > a) {
        a = b;
    }
    if (c > a) {
        a = c;
    }
    console.log(a);
}

biggestOfThree(["5","2","2"]);
biggestOfThree(["-2","-2","1"]);
biggestOfThree(["-2","4","3"]);
biggestOfThree(["0","-2.5","5"]);
biggestOfThree(["-0.1","-0.5","-1.1"]);
