<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr bgcolor="#9acd32">
						<th style="text-align:center">title</th>
						<th style="text-align:center">author</th>
						<th style="text-align:center">category</th>
						<th style="text-align:center">year</th>
						<th style="text-align:center">price</th>
					</tr>
					<xsl:for-each select="bookstore/book">
						<tr>
							<td>
								<xsl:value-of select="title"/>
							</td>
							<td>
								<xsl:value-of select="author"/>
							</td>
							<td>
								<xsl:value-of select="category"/>
							</td>
							<td>
								<xsl:value-of select="year"/>
							</td>
							<td>
								<xsl:value-of select="price"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
