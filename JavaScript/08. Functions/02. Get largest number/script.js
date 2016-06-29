function methodName(arguments) {
    var array = arguments[0].split(' '),
        a = +array[0],
        b = +array[1],
        c = +array[2],
        result = 0;
    result = GetMax(a, b, c);
    console.log(result);

    function GetMax(a, b, c) {
        if (a >= b & a >= c) {
            return a;
        } else if (b >= a & b >= c) {
            return b;
        } else {
            return c;
        }
    }
}

methodName(["8 3 6"]);
