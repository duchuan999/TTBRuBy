require 'test_helper'

class DmdvtsControllerTest < ActionController::TestCase
  setup do
    @dmdvt = dmdvts(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmdvts)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmdvt" do
    assert_difference('Dmdvt.count') do
      post :create, dmdvt: { stt: @dmdvt.stt, ten: @dmdvt.ten }
    end

    assert_redirected_to dmdvt_path(assigns(:dmdvt))
  end

  test "should show dmdvt" do
    get :show, id: @dmdvt
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmdvt
    assert_response :success
  end

  test "should update dmdvt" do
    patch :update, id: @dmdvt, dmdvt: { stt: @dmdvt.stt, ten: @dmdvt.ten }
    assert_redirected_to dmdvt_path(assigns(:dmdvt))
  end

  test "should destroy dmdvt" do
    assert_difference('Dmdvt.count', -1) do
      delete :destroy, id: @dmdvt
    end

    assert_redirected_to dmdvts_path
  end
end
