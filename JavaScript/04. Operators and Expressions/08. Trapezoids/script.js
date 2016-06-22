function trapezoids(arguments) {
    var a = parseFloat(+arguments[0]);
    var b = parseFloat(+arguments[1]);
    var h = parseFloat(+arguments[2]);
    var result = (a + b) * h / 2;
    console.log(result.toFixed(7));
}

trapezoids(["5", "7", "12"]);
