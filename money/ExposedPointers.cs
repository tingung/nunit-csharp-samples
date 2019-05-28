namespace NUnit.Samples.Money 
{

	using System;
    
	public class ExposedPointers
   {
      // Violates rule: PointersShouldNotBeVisible.
      public IntPtr publicPointer1;
      public UIntPtr publicPointer2;
      protected IntPtr protectedPointer;

      // Satisfies the rule.
      internal UIntPtr internalPointer;
      private UIntPtr privatePointer;

      public readonly UIntPtr publicReadOnlyPointer;
      protected readonly IntPtr protectedReadOnlyPointer;
   }
}
