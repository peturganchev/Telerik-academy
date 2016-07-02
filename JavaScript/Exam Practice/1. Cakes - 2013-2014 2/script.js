function methodName (args) {
  var s= +args[0],
      c =[
        +args[1],
        +args[2],
        +args[3],
      ],
  sum = 0,
  maxsum = 0,
  i,j,k;
  for ( i = 0; i <= s/c[2]; i++) {
    for (j = 0; j <= s/c[1]; j++) {
      for (k = 0; k <= s/c[0]; k++) {
        if ((c[0]*k+c[1]*j+c[2]*i) <= s) {
          sum = c[0]*k+c[1]*j+c[2]*i;
          if (sum>maxsum) {
            maxsum = sum;
          }
        }
      }
    }
  }
  console.log(maxsum);
}

methodName(['110', '13', '15', '17']);
methodName(['20', '11', '200', '300']);
