using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HomeFarm
{
    class DLL
    {
        DALL dal = null;

        public DataTable ExibirDadosDal()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new DALL();

                DataT = dal.ExibirDados();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable ExibirDadosDalFuncionario()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new DALL();

                DataT = dal.ExibirDadosFuncionarios();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable ExibirDadosDalPropriedades()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new DALL();

                DataT = dal.ExibirDadosPropriedades();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public DataTable ExibirDadosDalEstoque()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new DALL();

                DataT = dal.ExibirDadosMedicamentos();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable ExibirDadosDalProducao()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new DALL();

                DataT = dal.ExibirDadosProducao();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable ExibirDadosDalRacao()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new DALL();

                DataT = dal.ExibirDadosRacao();
                return DataT;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        /*
        public DataTable ExibirDadosDalUsuario()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new DALL();

                DataT = dal.ExibirDadosUsuarios();
                return DataT;

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
        */


    }
}
