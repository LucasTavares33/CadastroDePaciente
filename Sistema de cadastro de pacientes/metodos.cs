using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_cadastro_de_pacientes
{
    public class metodos
    {
        public string Cadastrar(Paciente pessoa)   
        {
            string file; 
            file = "PACIENTES.txt";
            WriteFile(pessoa, file);

            return "Cadastro realizado com sucesso!";


        }
        public int PacienteId() 
        {
            string file2 = "PACIENTES.txt";
            List<string []> listaPaciente = ReadFile(file2);
            string[] ultima = listaPaciente.Last(); //(listaPaciente.Lenght - 1);
            int soma = Convert.ToInt32(ultima[0]) + 1;
            return soma;
        }

        public List<string[]> ReadFile(string file2)
        {
            string[] linhas = File.ReadAllLines(file2);
            List<string[]> list1 = new List<string[]>();
            
            for (int n = 0; n<linhas.Length; n++) 
            {
                list1.Add(linhas[n].Split('|'));
                
            }
            return list1;
        }
        public List<string> ReadText(string file2)
        {
            string[] linhas = File.ReadAllLines(file2);
            List<string> list1 = new List<string>();

            for (int n = 0; n < linhas.Length; n++)
            {
                list1.Add(linhas[n]);

            }
            return list1;
        }

        public void WriteFile(Paciente p, string fileName) 
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                //writer.WriteLine($"{p.id}|{p.nome}|{p.cpf}|{p.data}|{p.sexo}");
                writer.WriteLine("{0}|{1}|{2}|{3}|{4}", p.id, p.nome, p.cpf, p.data.ToShortDateString(), p.sexo);
            }
        }
    }
}
