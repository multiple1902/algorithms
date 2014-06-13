COMPILEROPTIONS=--define:DEBUG
RUNENVIRON=MONO_TRACE_LISTENER=Console.Error 

tests: \
	test-NextPermutation

test-NextPermutation.exe: mypermutation.fs test-NextPermutation.fsx
	fsharpc $(COMPILEROPTIONS) \
		-o test-NextPermutation.exe \
		mypermutation.fs test-NextPermutation.fsx

test-NextPermutation: test-NextPermutation.exe
	$(RUNENVIRON) mono test-NextPermutation.exe

clean:
	rm *.exe
