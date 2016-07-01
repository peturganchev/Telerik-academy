function youngerPerson (arguments) {
  var arr = arguments,
  minage = +arr[2],
  index = 0;
  for (var i = 0; i < arr.length; i+=3) {
    if (minage > +arr[i+2]) {
      minage = +arr[i+2];
      index = i;
    }
  }
  console.log(arr[index]+" "+arr[index+1]);
}
youngerPerson([
  'Penka', 'Hristova', '61',
  'System', 'Failiure', '88',
  'Bat', 'Man', '16',
  'Malko', 'Kote', '72'
]);
