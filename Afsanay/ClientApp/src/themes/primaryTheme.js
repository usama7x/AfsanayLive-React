/**
 * App Light Theme
 */
import { createMuiTheme } from '@material-ui/core/styles';

const theme = createMuiTheme({
   palette: {
		type: "light",
      primary: {
         main: '#283593'
      },
      secondary: {
         main: '#FF5722'
      }
	}
	,overrides: {
		MuiTableRow:{
			root: {
				height:48
			},
		},
	},
});

export default theme;