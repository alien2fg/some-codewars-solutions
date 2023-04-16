#include <sstream>
#include <string>

struct PrimeDecomp {
  static std::string factors(int n);
};

std::string PrimeDecomp::factors(int n) {
  std::ostringstream res;
  for (int i = 2; n > 1; i++) {
    int k = 0;
    while (n % i == 0) {
      n /= i;
      k++;
    }
    if (k == 1)
      res << '(' << i << ')';
    else if (k > 1)
      res << '(' << i << "**" << k << ')';
  }
  return res.str();
}
