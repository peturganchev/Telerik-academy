function RemoveElements (args) {
  var arr = args,
      remove = arr[0];
      Array.prototype.remEl = function(removeMe){
        var result = [];
        for(var element in this){
      if (this[element] !== removeMe && typeof this[element] !== 'function') {
        result.push(this[element]);
      }
    }
   return result;
  };
  console.log(arr.remEl(remove).join('\n'));
}
RemoveElements([ '1', '2', '3', '2', '1', '2', '3', '2' ]);
