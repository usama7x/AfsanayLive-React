/**
 * site footer one component
 */
/* eslint-disable */
import React from 'react';
import Grid from '@material-ui/core/Grid';
import List from '@material-ui/core/List';
import { Link } from 'react-router-dom';

//icons
import PhoneEnabledIcon from '@material-ui/icons/PhoneEnabled';
import EmailIcon from '@material-ui/icons/Email';
import InstagramIcon from '@material-ui/icons/Instagram';
import FacebookIcon from '@material-ui/icons/Facebook';
import TwitterIcon from '@material-ui/icons/Twitter';

// intl message
import IntlMessages from '../../../util/IntlMessages';


export default function CustomFooter(props) {

   const { about } = props.data;
   return (
       <>
       <div className="container mb-20 mt-30" >
            <Grid container>
                 <Grid item xs={0} sm={0} md={2} lg={4} xl={4}>
                 </Grid>
                 <Grid item xs={12} sm={12} md={8} lg={4} xl={4}>
                    <div className="container" style={{display: 'flex', justifyContent: 'space-around'}} >
                        <PhoneEnabledIcon />
                        <EmailIcon />
                        <InstagramIcon />
                        <FacebookIcon />
                        <TwitterIcon />
                    </div>
                 </Grid>
                 <Grid item xs={0} sm={0} md={2} lg={4} xl={4}>
                 </Grid>
            </Grid>
        </div>
        <footer className="iron-footer-v1">
            <div className="iron-footer-bottom">
                <div className="container">
                <Grid container style={{display: 'block'}}>
                    <List component="nav" className="iron-footer-menu-list" style={{display: 'flex', justifyContent: 'space-around', flexWrap: 'wrap'}}>
                            {
                                about.map((title, key) => {
                                    return (
                                        <li key={key} className="list-item">
                                            {/* {title.menu_title} */}
                                        <Link to={title.path}>
                                            <IntlMessages id={title.menu_title} />
                                        </Link>
                                        </li>
                                    )
                                })
                            }
                            </List>
                </Grid>
                </div>
            </div>
        </footer>
      </>
   )
}
