# dotnet-basex
A simple class to convert integers to and from base*X* (36, 62, etc.) that is easy to use, easy to understand and easy to expand on.  

This is probably not the fastest way to do this.  If you are trying to make every cycle count, maybe look elsewhere.  This is more than fast enough for 99.9% of use-cases.

## Free Use
Use this code however you want, rename it, bury it in you code, take credit for it.  It's all good!

Just respect the MIT license terms and don't expect any warranty.  I have enough on my plate.

I'm sure I'm not the first to come up with an implementation like this.


## Usage
```csharp
void Main()
{
    // encode/decode as Base36

    long val = Environment.TickCount64;
    System.Console.WriteLine(val);

    string enc = Base36.Encode(val);
    System.Console.WriteLine(enc);

    long dec = Base36.Decode(enc);
    System.Console.WriteLine(dec);

    bool ok = (val == dec);
    System.Console.WriteLine(ok);
}
```

and now for something completely different...
```csharp
void Main()
{
    // because why not?
    const string base27 = "0123456789abcdefghijklmnopq";

    long val = Environment.TickCount64;
    System.Console.WriteLine(val);

    string enc = BaseX.Encode(val, base27);
    System.Console.WriteLine(enc);

    long dec = BaseX.Decode(enc, base27);
    System.Console.WriteLine(dec);

    bool ok = (val == dec);
    System.Console.WriteLine(ok);
}
```

