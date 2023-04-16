#include <string>
using namespace std;
string sum_strings(const string& a, const string& b) {
  string str;
  int p=0, w, i, j, k, n;
  i = a.length( );
  j = b.length( );
  n = i; if( j < i ) n = j;
  str="";
  for( k = 1; k <= n; k++ )
  {
    w  = ( int ) ( a [ --i ] ) + ( int ) ( b [ --j ] ) + p - 96;
    p  = w / 10;
    str = ( char ) ( ( w % 10 ) + 48 ) + str;
  }
  while( i )
  {
    w  = a [ --i ] + p - 48;
    p  = w / 10;
    str = ( char ) ( ( w % 10 ) + 48 ) + str;
  }

  while( j )
  {
    w  = b [ --j ] + p - 48;
    p  = w / 10;
    str = ( char ) ( ( w % 10 ) + 48 ) + str;
  }

  if( p ) str = ( char ) ( p + 48 ) + str;



  if( str == "" ) str = "0";

  return str;
