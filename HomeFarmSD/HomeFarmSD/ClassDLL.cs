using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HomeFarmSD
{
    class ClassDLL
    {
        ClassDAL dal = null;

        public DataTable ExibirDadosDal()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new ClassDAL();

                DataT = dal.ExibirDados();
                return DataT;

            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public DataTable ExibirDadosDalEquino()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new ClassDAL();

                DataT = dal.ExibirDadosEquino();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public DataTable ExibirDadosDalOvino()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new ClassDAL();

                DataT = dal.ExibirDadosOvino();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public DataTable ExibirDadosDalSuino()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new ClassDAL();

                DataT = dal.ExibirDadosSuino();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }


        public DataTable ExibirDadosDalCampo()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new ClassDAL();

                DataT = dal.ExibirDadosCampos();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public DataTable ExibirDadosDalUsuario()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new ClassDAL();

                DataT = dal.ExibirDadosUsuarios();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
    }
}
