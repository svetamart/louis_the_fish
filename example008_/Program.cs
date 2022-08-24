// стихийный подход

// int a = 22;
// int b = 15;
// int c = 33;
// int d = 39;
// int e = 33;
// int f = 23;
// int g = 40;
// int h = 2;
// int i = 313;

// int max = a;

// if(b > max) max = b;
// if(c > max) max = c;
// if(d > max) max = d;
// if(e > max) max = e;
// if(f > max) max = f;
// if(g > max) max = g;
// if(h > max) max = h;
// if(i > max) max = i;

// Console.WriteLine(max);


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a = 22;
int b = 15;
int c = 37753;
int d = 39;
int e = 33;
int f = 23;
int g = 4110;
int h = 2;
int i = 313;

// int max1 = Max(a, b, c);
// int max2 = Max(d, e, f);
// int max3 = Max(g, h, i);

int max = Max(
    Max(a, b, c), 
    Max(d, e, f),
    Max(g, h, i));

Console.WriteLine(max);
