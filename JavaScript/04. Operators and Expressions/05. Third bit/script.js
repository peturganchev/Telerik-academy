function thirdBit(arguments) {
    var number = parseInt(arguments[0]);
    var test = 3;
    var mask = 1 << test;
    var bit = (number & mask) >> test;
    console.log(bit);
}
