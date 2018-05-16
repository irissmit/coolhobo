List<string> list = new List<string>()
{
    "Shenzhen",
    "Xiamen",
    "Bejing",
    "Shanghai",
    "Hongkong"
};

list.Sort((x, y) => -x.CompareTo(y));