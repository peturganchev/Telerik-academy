function methodName (args) {
  var input = args[0].split("\n"),
  n = +input[0],
  numbers = input.slice(1),
  min  = numbers[0];
      for (var i = 0; i < n; i++) {
        min = +numbers[i];
        for (var j = i; j < n; j++) {
          if (numbers[j] < min) {
            min = +numbers[j];
            numbers[j] = +numbers[i];
            numbers[i] = min;
          }
        }
      }
  console.log(numbers.join("\n"));
}
methodName(['6\n3\n4\n1\n5\n2\n6']);
