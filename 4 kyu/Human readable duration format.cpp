#include <iostream>
#include <string> 
using namespace std;
string text(int y, int d, int h, int m, int s)
{
    string time, a = " year", b = " day", c = " hour", da = " minute", e = " second";
    if (y == 0 && d == 0 && h == 0 && m == 0 && s == 0) return"now";
    if (y == 1) {
        time = time + to_string(1) + a;
        if ((d != 0 && h == 0 && m == 0 && s == 0) || (d == 0 && h != 0 && m == 0 && s == 0) || (d == 0 && h == 0 && m != 0 && s == 0) || (d == 0 && h == 0 && m == 0 && s != 0)) time = time + " and ";
        else if (d != 0 || h != 0 || m != 0 || s != 0) time = time + ", ";
    }
    if (y != 1 && y != 0) {
        time = time + to_string(y) + a + "s";
        if ((d != 0 && h == 0 && m == 0 && s == 0) || (d == 0 && h != 0 && m == 0 && s == 0) || (d == 0 && h == 0 && m != 0 && s == 0) || (d == 0 && h == 0 && m == 0 && s != 0)) time = time + " and ";
        else if (d != 0 || h != 0 || m != 0 || s != 0) time = time + ", ";
    }
    if (d == 1) {
        time = time + to_string(1) + b;
        if ((h != 0 && m == 0 && s == 0) || (h == 0 && m != 0 && s == 0) || (h == 0 && m == 0 && s != 0)) time = time + " and ";
        else if (h != 0 || m != 0 || s != 0) time = time + ", ";
    }
    if (d != 1 && d != 0) {
        time = time + to_string(d) + b + "s";
        if ((h != 0 && m == 0 && s == 0) || (h == 0 && m != 0 && s == 0) || (h == 0 && m == 0 && s != 0)) time = time + " and ";
        else if (h != 0 || m != 0 || s != 0) time = time + ", ";
    }
    if (h == 1) {
        time = time + to_string(1) + c;
        if ((m != 0 && s == 0) || (m == 0 && s != 0)) time = time + " and ";
        else if (m != 0 || s != 0)time = time + ", ";
    }
    if (h != 1 && h != 0) {
        time = time  + to_string(h) + c + "s";
        if ((m != 0 && s == 0) || (m == 0 && s != 0)) time = time + " and ";
        else if (m != 0 || s != 0)time = time + ", ";
    }
    if (m == 1) {
        time = time + to_string(1) + da;
        if (s != 0)time = time + " and ";
    }
    if (m != 1 && m != 0) {
        time = time + to_string(m) + da + "s";
        if (s != 0)time = time + " and ";
    }
        if (s == 1) time = time + to_string(1) + e;
        if (s != 1 && s != 0)time = time + to_string(s) + e + "s";
        
    return time;
}
string format_duration(int seconds) {
    if (seconds == 0) return "now";
    int years = seconds / 31556952;
    int days = (seconds / 86400) % 365;
    int hours = (seconds / 3600) % 24;
    int minutes = (seconds / 60) % 60;
    int sec = seconds % 60;
    return text(years, days, hours, minutes, sec);
}
