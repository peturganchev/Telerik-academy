function methodName(args) {
    var n = +args[0],
        numbers = args[1].split(' ').map(Number),
        result = 0;
    result = neightbours(n, numbers);
    console.log(result);

    function neightbours(n, numbers) {
        var result = -1;
        for (var i = 1; i < n - 1; i++) {
            if (numbers[i] > numbers[i - 1] & numbers[i] > numbers[i + 1]) {
                result = i;
                return result;
            }
        }
        return result;
    }
}
methodName(["6","-26 -25 -28 31 2 27"]);
