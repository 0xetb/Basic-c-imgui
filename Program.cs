using ClickableTransparentOverlay;
using ImGuiNET;
using System.Net.Http.Headers;
using System.Numerics;

namespace BasicImGui
{
    class Program : Overlay
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        protected override void Render()
        {
            ImGui.Begin("C# ImGui !");
            ImGui.SetWindowSize(new Vector2(500, 500));
            ImGui.SetCursorPos(new Vector2(250, 250));
            ImGui.Text("Made by 0xetb");
        }
    }
}