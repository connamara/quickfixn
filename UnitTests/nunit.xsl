<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0"	
                exclude-result-prefixes="msxsl"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
		xmlns:msxsl="urn:schemas-microsoft-com:xslt">
<xsl:output method="html" indent="yes" />
<xsl:template match="test-results">
	<html>
		<body>
			<h2>QuickFIX/n Unit Tests</h2>
			<xsl:variable name="total" select="@total + @not-run" />
   			<xsl:variable name="success" select="@total - @failures - @errors" />
    			<table border="0" cellspacing="2" cellpadding="2">
      				<tr bgcolor="#dddddd">
        				<td>Number of Tests</td>
        				<td>
          					<tt><xsl:value-of select="$total" /></tt>
        				</td>
      				</tr>
      				<tr bgcolor="#99ff00">
        				<td>Success</td>
        				<td>
          					<tt><xsl:value-of select="$success" />  (<xsl:value-of select="round(number($success) div number($total) * 1000) div 10" />%)</tt>
       					 </td>
      				</tr>
      				<tr bgcolor="#ffbb00">
        				<td>Failure</td>
        				<td>
         					 <tt><xsl:value-of select="@failures" /> (<xsl:value-of select="round(number(@failures) div number($total) * 1000) div 10" />%)</tt>
        				</td>
      				</tr>
      				<tr bgcolor="#ff6666">
        				<td>Error</td>
        				<td>
         					 <tt><xsl:value-of select="@errors" />  (<xsl:value-of select="round(number(@errors) div number($total) * 1000) div 10" />%)</tt>
        				</td>
      				</tr>
      				<tr bgcolor="#ffffcc">
       					<td>Skipped</td>
        				<td>
          					<tt><xsl:value-of select="@not-run" />  (<xsl:value-of select="round(number(@not-run) div number($total) * 1000) div 10" />%)</tt>
       		 			</td>
      				</tr>	
   			</table>
   			<br/>
    			<table border="0" cellspacing="2">
				<xsl:for-each select="test-suite/results/test-suite/results/test-suite">
					<tr bgcolor="#6688dd">
						<th><xsl:value-of select="@name" /></th>
						<th>Executed</th>
						<th>Passed</th>
						<xsl:for-each select="results/test-case">
							<tr>
								<td><xsl:value-of select="@name" /></td>

								<xsl:choose>
									<xsl:when test="@executed = 'True'">
										<td  bgcolor="#99ff00">
											<xsl:value-of select="@executed" />
										</td>
									</xsl:when>
									<xsl:otherwise>
										<td bgcolor="#ffffcc">
											<xsl:value-of select="@executed" />
										</td>
									</xsl:otherwise>
								</xsl:choose>

								<xsl:choose>
									<xsl:when test="@success = 'True'">
										<td  bgcolor="#99ff00">
											<xsl:value-of select="@success" />
										</td>
									</xsl:when>
									<xsl:when test="@success = 'False'">
										<td  bgcolor="#ff9900">
											<xsl:value-of select="@success" />
										</td>
									</xsl:when>
									<xsl:otherwise>
										<td>
											<xsl:value-of select="@success" />
										</td>
									</xsl:otherwise>
								</xsl:choose>
							</tr>
							<xsl:if test="failure">
        							<div class="code">
            							<tr bgcolor="#ff9900">
	      								<td>
                                                                        	<pre>Test Failure:</pre>
										<pre><xsl:value-of select="failure/message" /></pre>
										<pre><xsl:value-of select="failure/stack-trace" /></pre>
	      								</td>
	    							</tr>
 								</div>
    							</xsl:if>
						</xsl:for-each>
					</tr>
				</xsl:for-each>
			</table>
		</body>
  	</html>
</xsl:template>
</xsl:stylesheet>
