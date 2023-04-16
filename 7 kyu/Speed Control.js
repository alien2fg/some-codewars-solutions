function gps(s,x){
  if(x.length <= 1){
    return 0
  }
   speed = []
   for(var i=0; i<x.length-1; i++){
     speed.push((x[i+1]-x[i])*3600/s)
   }
   return Math.floor(Math.max(...speed))
}
