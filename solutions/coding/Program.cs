using Coding.ArraysAndHashing;

var filter = args.Length > 0 ? args[0].ToLower() : "all";

if (filter == "all" || filter == "targetsum")
    TargetSum.RunTests();
