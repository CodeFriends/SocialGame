using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public int[] CarregaGrafo(int id)
    {
        IList<int> resultados = new List<int>();
        string line = "";
        try
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files\swipl\");
            String[] param = { "-q", "-f", "C:\\PredicadosProlog\\odbc.pl" };
            PlEngine.Initialize(param);
            using (PlQuery q = new PlQuery("nodos(" + id + ", X,Y,Z)"))
            {
                foreach (PlQueryVariables v in q.SolutionVariables)
                {
                    Console.Clear();
                    Console.WriteLine(v["X"].ToString());
                    line = v["X"].ToString();
                    if (line != null)
                        resultados.Add(Convert.ToInt32(line));

                    Console.WriteLine(v["Y"].ToString());
                    line = v["Y"].ToString();
                    if (line != null)
                        resultados.Add(Convert.ToInt32(line));

                    Console.WriteLine(v["Z"].ToString());
                    line = v["Z"].ToString();
                    if (line != null)
                        resultados.Add(Convert.ToInt32(line));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            PlEngine.PlCleanup();
        }
        return resultados.ToArray();

    }
}
