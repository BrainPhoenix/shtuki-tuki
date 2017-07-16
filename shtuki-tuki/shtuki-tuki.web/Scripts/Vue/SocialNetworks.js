var linkSocialNav = new Vue({
    el: '.vue-social-nav',
    data: {
        linkInstNav: '',
        linkVkNav: '',
        linkOkNav: ''
    }
});

var linkSocialFooter = new Vue({
    el: '.vue-social-footer',
    data: {
        linkInstFooter: '',
        linkVkFooter: '',
        linkOkFooter: '',
        phoneFooter: '',
        mailFooter:''
    }
});

var linkSocialIndex = new Vue({
    el: '.vue-social-index',
    data: {
        linkInstIndex: '',
        linkVkIndex: '',
        linkOkIndex: '',
        phoneIndex: '',
        mailIndex: ''
    }
});

var linkSocialContacts = new Vue({
    el: '.vue-social-contacts',
    data: {
        linkInstContacts: '',
        linkVkContacts: '',
        linkOkContacts: '',
        phoneContacts: '',
        mailContacts: ''
    }
});

var linkSoicialNetworks = new Vue({
    created: function () {
        $.ajax({
            type: 'GET',
            url: '/api/WebSocialNetworks',
            success: function (response) {
                linkSocialNav.$data.linkInstNav = response.SocialNetworks[0].LinkNetwork;
                linkSocialNav.$data.linkVkNav = response.SocialNetworks[1].LinkNetwork;
                linkSocialNav.$data.linkOkNav = response.SocialNetworks[2].LinkNetwork;

                linkSocialIndex.$data.linkInstIndex = response.SocialNetworks[0].LinkNetwork;
                linkSocialIndex.$data.linkVkIndex = response.SocialNetworks[1].LinkNetwork;
                linkSocialIndex.$data.linkOkIndex = response.SocialNetworks[2].LinkNetwork;
                linkSocialIndex.$data.phoneIndex = response.Contacts.Phone;
                linkSocialIndex.$data.mailIndex = response.Contacts.Email;

                linkSocialContacts.$data.linkInstContacts = response.SocialNetworks[0].LinkNetwork;
                linkSocialContacts.$data.linkVkContacts = response.SocialNetworks[1].LinkNetwork;
                linkSocialContacts.$data.linkOkContacts = response.SocialNetworks[2].LinkNetwork;
                linkSocialContacts.$data.phoneContacts = response.Contacts.Phone;
                linkSocialContacts.$data.mailContacts = response.Contacts.Email;

                linkSocialFooter.$data.linkInstFooter = response.SocialNetworks[0].LinkNetwork;
                linkSocialFooter.$data.linkVkFooter = response.SocialNetworks[1].LinkNetwork;
                linkSocialFooter.$data.linkOkFooter = response.SocialNetworks[2].LinkNetwork;
                linkSocialFooter.$data.phoneFooter = response.Contacts.Phone;
                linkSocialFooter.$data.mailFooter = response.Contacts.Email
            },
            error: function (xhr) {
                console.log(xhr.status);
            }
        });
    }
});