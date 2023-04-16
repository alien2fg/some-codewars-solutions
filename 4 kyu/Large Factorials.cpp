#include <string>
inline int Digit( char c )  { return int(c - 48); }      // Function converting a character to a digit
 
inline char Char( int n ) { return char(n + 48); }        // Function converting a digit to a character
 
std::string Addition( std::string &A, std::string &B )
{    
while( A.length() != B.length() )        // Compare the length of the strings
{
if( A.length() > B.length() )     // If one is shorter, add zeros
{
B = "0" + B;
}
else A = "0" + A;
}
 
std::string Result = "";  // The sum result
int Carry = 0;      // Auxiliary variable
 
for(int i = A.length()-1; i >= 0; i-- )  // The addition algorithm itself
{
int sum = Digit(A[i]) + Digit(B[i]) + Carry;        // Calculate the sum of the corresponding digits
Result = Char(sum % 10) + Result;                        // Save it to the Result variable
Carry = int(sum / 10);
}
 
if( Carry != 0 ) Result = Char(Carry) + Result;        // If there is still a carry left, add it to the beginning
 
return Result;
}
 
std::string Multiplication( std::string STR, unsigned long long int INT )
{
std::string Result = "0";
 
unsigned long long i ;
 
for(i = 1; i; i <<= 1)
{
if(INT & i) Result = Addition(Result, STR);
STR = Addition(STR, STR);
}
 
return Result; 
}
 
std::string factorial(int n){
if (n < 0) return "";
if(n == 1) return "1";
 std::string fa = "1";
for(int i = 2; i <= n; i++){
  fa = Multiplication(fa, i);
}  
return fa;
}
