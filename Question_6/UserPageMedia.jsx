// Блок медиа текущего пользователя
// Состоит из:
// Блок Подарков
// Блок Фотографий
// Блок Видео
// Блок Друзей
// еще какие-то блоки должны быть
class UserPageMedia {
    render() {
        return (<div className="user_page_media">
            <UserPageGifts />
            <UserPagePhoto />
            <UserPageVideo />
            <UserPageFriends />
        </div>);
    }
}
