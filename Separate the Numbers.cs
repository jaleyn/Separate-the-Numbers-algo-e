#include <bits/stdc++.h>

using namespace std;

string ltrim(const string &);
string rtrim(const string &);

/*
 * Complete the 'separateNumbers' function below.
 *
 * The function accepts STRING s as parameter.
 */

void separateNumbers(string s) {
 int len = s.length();
    bool found = false;

    
    for (int i = 1; i <= len / 2; i++) {
        string firstStr = s.substr(0, i);
        long long firstNum = stoll(firstStr);
        long long nextNum = firstNum + 1;
        int pos = i;

        while (pos < len) {
            string nextStr = to_string(nextNum);
            if (s.substr(pos, nextStr.length()) != nextStr)
                break;
            pos += nextStr.length();
            nextNum++;
        }

        if (pos == len) {
            cout << "YES " << firstNum << endl;
            found = true;
            break;
        }
    }

    if (!found)
        cout << "NO" << endl;
}

int main()
{
    string q_temp;
    getline(cin, q_temp);

    int q = stoi(ltrim(rtrim(q_temp)));

    for (int q_itr = 0; q_itr < q; q_itr++) {
        string s;
        getline(cin, s);

        separateNumbers(s);
    }

    return 0;
}

string ltrim(const string &str) {
    string s(str);

    s.erase(
        s.begin(),
        find_if(s.begin(), s.end(), not1(ptr_fun<int, int>(isspace)))
    );

    return s;
}

string rtrim(const string &str) {
    string s(str);

    s.erase(
        find_if(s.rbegin(), s.rend(), not1(ptr_fun<int, int>(isspace))).base(),
        s.end()
    );

    return s;
}
