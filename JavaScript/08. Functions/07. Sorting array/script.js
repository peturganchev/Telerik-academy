function methodName (args) {
      var n = +args[0],
          numbers = args[1].split(' ').map(Number),
          sortedArray = numbers.sort(function(a, b) {
            return a - b;
          });
          console.log(sortedArray.join(" "));
}

methodName(["6","3 4 1 5 2 6"]);
