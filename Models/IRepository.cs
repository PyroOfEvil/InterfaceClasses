namespace Class_2.bin
{
    public interface IRepository
    {
         void Add();
         void Get();
         void GetByID(int id);
    }
    public class FileRepository : IRepository {
        public void Add(){
            throw new NotImpletmentedException();
        }
        public void Get(){
            throw new NotImpletmentedException();
        }
    }
}