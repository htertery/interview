using Coding.ArraysAndHashing;
using Coding.SlidingWindow;
using Coding.DynamicProgramming;

var filter = args.Length > 0 ? args[0].ToLower() : "all";

if (filter == "all" || filter == "targetsum")
    TargetSum.RunTests();

if (filter == "all" || filter == "maxcontsum")
    MaxContiguousSum.RunTests();

if (filter == "all" || filter == "longmaxuniquesub")
    LongestSubstringUniqueChars.RunTests();

if (filter == "all" || filter == "maxavgsum")
MaxAvgSub.RunTests();

if (filter == "all" || filter == "climbstairs")
ClimbingStairs.RunTests();

if (filter == "all" || filter == "climbcost")
ClimbingCost.RunTests();

if (filter == "all" || filter == "houserobber")
HouseRobber.RunTests();

if (filter == "all" || filter == "uniquepaths")
    UniquePaths.RunTests();

if (filter == "all" || filter == "longestcommonsub")
    LongestCommonSub.RunTests();

if (filter == "all" || filter == "editdistance")
    EditDistance.RunTests();