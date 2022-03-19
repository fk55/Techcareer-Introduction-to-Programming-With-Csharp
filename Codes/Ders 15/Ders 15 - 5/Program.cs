// See https://aka.ms/new-console-template for more information

/********** Recursive metotlar *********/

/* Metotlar kendi içlerinde kendilerini çağırabilir. Bu tür metotlara tekrarlı, recursive metotlar denir
 * Performans açısından pek iyi değildir çünkü son aşamaya ulaşana dek kaç kere çağrıldıysa ramde açık bulunacaktır.
 * Duruma göre değerlendirip iteratif veya recursive şekilde çözüm düşünülmelidir.
 */

static int getFactorial(int number) // Mesela bu örnekte iteratif yapmak daha az performans yiyen bir çözümdür. 
{
    int result = 1;

    if (number == 0 || number ==1)
    {
        result = 1;
    }
    else if (number > 1)
    {
        result = number * getFactorial(number - 1);
    }

    return result;
}

static int getFibonacci(int order)
{
    if (order == 1 || order == 2)
    {
        return 1;
    }
    else
    {
        return getFibonacci(order - 2) + getFibonacci(order - 1);
    }
}