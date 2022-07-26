using MonitoringLib;
using static System.Console;

int[] numbers = Enumerable.Range(0, 50_000).ToArray();

WriteLine("String con +");
Recorder.Start();

string s = string.Empty;

for (int i = 0; i < numbers.Length; i++)
{
    s+= numbers[i] + ", ";
}

Recorder.Stop();

WriteLine("String con stringBuilder");

Recorder.Start();

System.Text.StringBuilder sb = new System.Text.StringBuilder();

for (int i = 0; i < numbers.Length; i++)
{
    sb.Append(numbers[i]);
    sb.Append(", ");
}

Recorder.Stop();
