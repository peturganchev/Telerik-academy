function Matrix(arguments) {
    var N = arguments[0],
        string = "";
    for (var i = 0; i < N; i++) {
        for (var j = 0; j < N; j++) {
            string += (j + 1 + i) + " ";
        }
        console.log(string);
        string = "";
    }
}

Matrix(['2']);
Matrix(['3']);
