//Builder
namespace DeveloperKataDesign.Computer
{
        public class ComputerBuilder{
            private Computer computer;
            private MotherBoard motherBoard;
            private Memory memory;
            private GraphicCard graphicCard;
            private GodMotherBoard godMotherBoard;

            public ComputerBuilder()
            {
                computer = new Computer();
            }

            public ComputerBuilder WithGodMotherBoard(GodCPU godCPU){
                godMotherBoard = new GodMotherBoard();
                godMotherBoard.AddComponent(godCPU);

                return this;
            } 
            public ComputerBuilder WithMotherBoard(params CPU[] cpus){
                motherBoard = new MotherBoard();
                foreach (var cpu in cpus)
                {
                    motherBoard.AddComponent(cpu);
                }

                return this;
            }

            public ComputerBuilder WithGraphicCard(int score){
                graphicCard = new GraphicCard(score);
                return this;
            }

            public ComputerBuilder WithMemory(params Ram[] rams){
                memory = new Memory();
                foreach (var ram in rams)
                {
                    memory.AddComponent(ram);                
                }

                return this;
            }
            public Computer Build(){
                computer.AddComponent(motherBoard);
                computer.AddComponent(memory);
                computer.AddComponent(graphicCard);
                computer.AddComponent(godMotherBoard);

                return computer;
            }
        }

}