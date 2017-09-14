import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class FileTest {
	private File file;

	@Before
	public void setUp() throws Exception {
		file = new File();
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testAbs() {
		assertEquals(file.abs(14), 14);
		assertEquals(file.abs(-5), 5);
		assertEquals(file.abs(0), 0);
	}
}